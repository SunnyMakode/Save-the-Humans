namespace EventPlanner
{
    class DinnerParty
    {
        public int NumberOfPerson;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations;
        public const int CostofFoodPerPerson = 25;

        public void CalculatecostOfDecorations(bool flag)
        {
            if (flag)
            {
                CostOfDecorations = (NumberOfPerson * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPerson * 7.50M) + 30M;
            }
        }

        public void SetHealthyOption(bool flag)
        {
            if (!flag)
            {
                CostOfBeveragesPerPerson = 25.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
        }

        public decimal calculateCost(bool healthFlag)
        {
            decimal totalCost = CostOfDecorations + (CostOfBeveragesPerPerson + CostofFoodPerPerson) * NumberOfPerson;

            if (healthFlag)
            {
                return totalCost * 0.95M;
            }
            return totalCost;
        }

    }
}

