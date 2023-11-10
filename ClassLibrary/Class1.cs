using System;

namespace ClassLibrary
{
    public class BookComparer : IComparer<Book>
    {
        public int Compare(Book b1, Book b2)
        {
            if(b1.YearOfPublishing > b2.YearOfPublishing) return 1;
            else if (b1.YearOfPublishing < b2.YearOfPublishing) return -1;
            return 0;
        }
    }
    public class Book : IComparable<Book>
    {
        private int serialNumber;
        private string name;
        private int yearOfPublishing;
        private int cost;
        private int numOfCopies;

        public int SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int YearOfPublishing
        {
            get { return yearOfPublishing; }
            set { yearOfPublishing = value; }
        }

        public int Cost 
        {
            get { return cost;  }
            set { cost = value; }
        }
        public int NumOfCopies
        {
            get { return numOfCopies; }
            set { numOfCopies = value; }
        }

        public int TotalCostOfCirculation
        {
            get { return cost * numOfCopies; }
        }

        public Book(int serialNumber, string name, int yearOfPublishing, int cost, int numOfCopies)
        {
            this.serialNumber = serialNumber;
            this.name = name;
            this.yearOfPublishing = yearOfPublishing;
            this.cost = cost;
            this.numOfCopies = numOfCopies;
        }

        public void increaseCostByPercentage(int percentage)
        {
            cost += cost * percentage;
        }

        public int CompareTo(Book b)
        {
            return YearOfPublishing.CompareTo(b.YearOfPublishing);
        }

        public override string ToString()
        {
            return $"Book \"{name}\", serial number - \"{serialNumber}\", year of publishing - {yearOfPublishing}, price - {cost}, number of copies - {numOfCopies}";
        }

    }
}