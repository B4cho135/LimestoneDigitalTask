using Core.Persistance;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using System.Xml.Schema;
using Core.Entities.CreditInfo;
using System.Xml;
using Models.CreditInfo;
using System.Xml.Serialization;
using AutoMapper;
using Models.AutoMapperProfiles;




//It is implemented very poorly because of lack of time
//full path to the files is indicated meaning, everytime you move the project you have to change paths to local machine directory
//It fully loads the document into the memory - Cant open 50gb file on 16 gb ram machine
//if the xml is not valid, nothing is logged into the database, which is very bad
//Since the model is so complex, automapper had to be configured and since I did not have time,
//I implemented model mapping manually
//Validation error logging is implemented, but the only way to determine on which part of xml data got invalidated
//is by Contract Code
//after streaming is implemented instead of fully loading xml into the memory, single element data can be logged into database
//to make it clear why it did not get validated
//if you want me to improve this part of the code, I will
//since you have indicated that I have only 4 hours to finish this and I have already been working for 6 :)


var _context = new DefaultDbContext();

XmlSchemaSet schema = new XmlSchemaSet();


var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new CreditInfoProfile());
});

IMapper mapper = mapperConfig.CreateMapper();

schema.Add("http://creditinfo.com/schemas/Sample/Data", @"C:\Users\badri\source\repos\LimestoneDigitalTask\XmlLoader\XmlSchema\CreditInfoSchema.xsd");

XDocument document = XDocument.Load(@"C:\Users\badri\source\repos\LimestoneDigitalTask\XmlLoader\Data.xml");

bool isValid = true;
document.Validate(schema, (s, e) =>
{

    isValid = false;
    var validationError = new ValidationFailedEntity()
    {
        ValidationError = e.Message,
        XmlData = "XmlData here"
    };

    _context.FailedValidations.Add(validationError);
    _context.SaveChanges();

    Console.WriteLine(e.Message);

});

if(isValid)
{
    Batch batch;

    XmlSerializer serializer = new XmlSerializer(typeof(Batch));

    using(var stream = File.Open(@"C:\Users\badri\source\repos\LimestoneDigitalTask\XmlLoader\Data.xml", FileMode.Open))
    {
        batch = (Batch)serializer.Deserialize(stream);
    }

    if(batch != null)
    {
        foreach (var contract in batch.Contracts)
        {
            
            var contractEntity = new ContractEntity()
            { 
                ContractCode = contract.ContractCode
            };


            if(contract.ContractData != null)
            {
                contractEntity.ContractData = new ContractDataEntity()
                { 
                    DateAccountOpened = contract.ContractData.DateAccountOpened,
                    DateOfLastPayment = contract.ContractData.DateOfLastPayment,
                    NextPaymentDate = contract.ContractData.NextPaymentDate,
                    PhaseOfContract = contract.ContractData.PhaseOfContract,
                    RealEndDate = contract.ContractData.RealEndDate
                };


                if(contract.ContractData.CurrentBalance != null)
                {
                    contractEntity.ContractData.CurrentBalance = new CurrentBalanceEntity()
                    {
                        Currency = contract.ContractData.CurrentBalance.Currency,
                        Value = contract.ContractData.CurrentBalance.Value
                    };
                }

                if (contract.ContractData.OverdueBalance != null)
                {
                    contractEntity.ContractData.OverdueBalance = new OverdueBalanceEntity()
                    {
                        Currency = contract.ContractData.OverdueBalance.Currency,
                        Value = contract.ContractData.OverdueBalance.Value
                    };
                }

                if (contract.ContractData.InstallmentAmount != null)
                {
                    contractEntity.ContractData.InstallmentAmount = new InstallmentAmountEntity()
                    {
                        Currency = contract.ContractData.InstallmentAmount.Currency,
                        Value = contract.ContractData.InstallmentAmount.Value
                    };
                }

                if (contract.ContractData.OriginalAmount != null)
                {
                    contractEntity.ContractData.OriginalAmount = new OriginalAmountEntity()
                    {
                        Currency = contract.ContractData.OriginalAmount.Currency,
                        Value = contract.ContractData.OriginalAmount.Value
                    };
                }
            }

            foreach(var individual in contract.Individual)
            {

                
                if (contract.Individual != null)
                {
                    contractEntity.Individual.Add(
                        new IndividualEntity()
                        {
                            CustomerCode = individual.CustomerCode,
                            DateOfBirth = individual.DateOfBirth,
                            FirstName = individual.FirstName,
                            Gender = individual.Gender,
                            LastName = individual.LastName,
                            NationalId = individual.IdentificationNumbers != null ? individual.IdentificationNumbers.NationalID : null
                        }
                    );
                    

                }
            }

            foreach(var role in contract.SubjectRole)
            {

                var subjectRoleEntity = new SubjectRoleEntity()
                {
                    CustomerCode = role.CustomerCode,
                    RoleOfCustomer = role.RoleOfCustomer

                };

                if (role.GuaranteeAmount != null)
                {
                    var currency = _context.Currencies.FirstOrDefault(x => x.Currency == role.GuaranteeAmount.Currency);

                    subjectRoleEntity.GuaranteeAmount = new GuaranteeAmountEntity()
                    {
                        Currency = role.GuaranteeAmount.Currency,
                        Value = role.GuaranteeAmount.Value
                    };
                }
                contractEntity.SubjectRole.Add(subjectRoleEntity);


            }


            _context.Contracts.Add(contractEntity);
            _context.SaveChanges();
        }

        Console.WriteLine("Finished\nExiting application...");
    }
    else
    {
        Console.WriteLine("Could not deserialze xml");
    }


}

Console.ReadKey();
