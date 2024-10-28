using HypotheekTool.Classes;

namespace Rock_IT_HypotheekTool;

public class UnitTest1
{
    //Here resides the test data of the project
    string yearlyIncomeResult = "10000";
    string studentDebtResult = "yes";
    string yearsOfInterestResult = "30";
    string postalCodeResult = "9677";

    //Whitelisted data
    string[] blackListedPostalCodes = ["9679", "9681", "9682"];

    //Blacklisted data
    string[] allowedInterestYears = ["1", "5", "10", "20", "30"];

    [Fact]
    public void YearlyIncomeTest()
    {
        int? yearlyIncome = null;
        if (yearlyIncome == null)
        {
            if (int.TryParse(yearlyIncomeResult, out int yearlyIncomeToInt))
            {
                yearlyIncome = yearlyIncomeToInt;
                Assert.Equal(yearlyIncomeResult, yearlyIncomeToInt.ToString());
            }
            else
            {
                Assert.Fail("YearlyIncome input is invalid");
            }
        }
    }

    [Fact]
    public void StudentDebtTest(){
        bool? hasStudentDebt = null;
        if (hasStudentDebt == null)
        {
            if (studentDebtResult is "Yes" or "yes")
            {
                hasStudentDebt = true;
                Assert.True(hasStudentDebt);
            }
            else if (studentDebtResult is "No" or "no")
            {
                hasStudentDebt = false;
                Assert.False(hasStudentDebt);
            }
            else
            {
                Assert.Fail("HasStudentDebt input is invalid");
            }
        }
    }

    [Fact]
    public void ValidYearsTest()
    {
        int? amountOfYears = null;
        if (amountOfYears == null)
        {
            if (int.TryParse(yearsOfInterestResult, out int yearsOfInterest) && allowedInterestYears.Contains(yearsOfInterestResult))
            {
                amountOfYears = yearsOfInterest;
                Assert.Equal(yearsOfInterestResult, amountOfYears.ToString());

            }
            else
            {
                Assert.Fail("YearsOfInterest input is invalid");
            }
        }
    }

    //TODO: code only checks blacklisted postalcodes non-existing postal codes still pass despite being invalid.
    [Fact]
    public void PostalCodeTest()
    {
        string postalCode = null;
        if (postalCode == null)
        {
            postalCode = postalCodeResult;
            if (blackListedPostalCodes.Contains(postalCodeResult))
            {
                Assert.Fail("PostalCode is blackListed");
            }
        }
    }

    [Fact]
    public void InputTests()
    {
        string postalCode = null;
        int? amountOfYears = null;
        int? yearlyIncome = null;
        bool? hasStudentDebt = null;

        //Get user data for calculations
        if (yearlyIncome == null)
        {
            if (int.TryParse(yearlyIncomeResult, out int yearlyIncomeToInt))
            {
                yearlyIncome = yearlyIncomeToInt;
                Assert.Equal(yearlyIncomeResult, yearlyIncomeToInt.ToString());
            }
            else
            {
                Assert.Fail("YearlyIncome input is invalid");
            }
        }

        if (hasStudentDebt == null)
        {
            if (studentDebtResult is "Yes" or "yes")
            {
                hasStudentDebt = true;
                Assert.True(hasStudentDebt);
            }
            else if (studentDebtResult is "No" or "no")
            {
                hasStudentDebt = false;
                Assert.False(hasStudentDebt);
            }
            else
            {
                Assert.Fail("HasStudentDebt input is invalid");
            }
        }

        if (amountOfYears == null)
        {
            if (int.TryParse(yearsOfInterestResult, out int yearsOfInterest) && allowedInterestYears.Contains(yearsOfInterestResult))
            {
                amountOfYears = yearsOfInterest;
                Assert.Equal(yearsOfInterestResult, amountOfYears.ToString());

            }
            else
            {
                Assert.Fail("YearsOfInterest input is invalid");
            }
        }

        if (postalCode == null)
        {
            postalCode = postalCodeResult;
            if (blackListedPostalCodes.Contains(postalCodeResult))
            {
                Assert.Fail("PostalCode is blackListed");
            }
        }
    }

    //switch (action)
    //        {
    //            case 1:
    //            BedragBerekenen bedragBerekenen = new BedragBerekenen();
    //            bedragBerekenen.Calculate(yearlyIncome, hasStudentDebt);
    //            break;
    //            case 2:
    //            HypotheekLastenBerekenen hypotheekLastenBerekenen = new HypotheekLastenBerekenen();
    //            hypotheekLastenBerekenen.Calculate(yearlyIncome, amountOfYears);
    //            break;
    //            case 3:
    //            AflossingenBerekenen aflossingenBerekenen = new AflossingenBerekenen();
    //            aflossingenBerekenen.Calculate(yearlyIncome, amountOfYears);
    //            break;
    //        }

    //        goto Start;
    //    }
    //}

    //[Fact]
    //public void PassingTest()
    //{
    //    Assert.Equal(4, Add(2, 2));
    //}

    //[Fact]
    //public void FailingTest()
    //{
    //    Assert.Equal(5, Add(2, 2));
    //}

    //int Add(int x, int y)
    //{
    //    return x + y;
    //}
}