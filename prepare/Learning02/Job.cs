public class Job
    {
        //Responsibilities: Keeps track of the company, job title, start year, and end year.

        public string _jobTitle = "";
        public string _company = "";
        public int _startYear = 0;
        public int _endYear = 0;

        // the fact that I have declared a constructor here allows for this
        // class' attributes to be all declared at the same time as the object
        public Job(string _jobTitle, string _company, int _startYear, int _endYear)
        {
            this._jobTitle = _jobTitle;
            this._company = _company;
            this._startYear = _startYear;
            this._endYear = _endYear;
        }

        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }

