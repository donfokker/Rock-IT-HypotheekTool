using HypotheekTool.Classes;

namespace Rock_IT_HypotheekTool;

public class IntergrationTest
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
            if (int.TryParse(yearsOfInterestResult, out int yearsOfInterest) &&
                allowedInterestYears.Contains(yearsOfInterestResult))
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
}