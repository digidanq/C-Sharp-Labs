using System;

class MyDate
{
    public int day;
    public int year;
    public int month;

    public MyDate(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    // --- is a leap year ---

    private bool IsLeapYear(int year)
    {
        return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
    }

    private int DayInMonth(int month, int year)
    {
        switch (month)
        {
            case 1: return 31;
            case 2: return IsLeapYear(year) ? 29 : 28;
            case 3: return 31;
            case 4: return 30;
            case 5: return 31;
            case 6: return 30;
            case 7: return 31;
            case 8: return 31;
            case 9: return 30;
            case 10: return 31;
            case 11: return 30;
            case 12: return 31;
            default: throw new ArgumentException("Nieprawidłowy miesiąc.");
        }
    }

    private void AddDays(int days)
    {
        day += days;

        while (day > DayInMonth(month, year))
        {
            day -= DayInMonth(month, year);
            month++;

            if(month > 12)
            {
                month = 1;
                year++;
            }
        }

        while(day < 1)
        {
            month--;

            if(month < 1)
            {
                month = 12;
                year--;
            }
            day += DayInMonth(month, year);
        }
    }

    public void AddWeek()
    {
        AddDays(7);
    }
    public void SubtractWeek()
    {
        AddDays(-7);
    }
    public string GetDate()
    {
        return $"{day:D2}.{month:D2}.{year}";
    }
}