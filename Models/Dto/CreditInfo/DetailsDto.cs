using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Dto.CreditInfo
{
    public class DetailsDto
    {
        public IndividualDto Individual { get; set; }
        public ContractDto Contract { get; set; }

        //I did not get this part
        //here I'm supposed to calculate
        //sum and max of some data, like : installments, OverdueBalance or the original amount
        //but as far as I can tell from the data model you gave me
        //there is only 1 original amount to the contract
        //1 installment amount and 1 overdueBalance
        //which is already shown in the model above - ContractDto
        //if you want me to calculate data from all contracts which includes the specific individual
        //then with which contract data should ContractDto model be filled?
        public Summary SummaryInformation { get; set; }
    }
}
