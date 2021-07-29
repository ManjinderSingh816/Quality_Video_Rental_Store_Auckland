namespace Quality_Video_Rental_Store_Auckland
{
    public class DatabaseModels
    {
        public int CstId { get; set; }
        public string CstName { get; set; }
        public string CstContact { get; set; }
        public string CstAddress { get; set; }
        public string CstAge { get; set; }
        public string CstGender { get; set; }
        public string CstIdentification { get; set; }


        public int VdId { get; set; }
        public string VdTitle { get; set; }
        public string VdRating { get; set; }
        public string VdYear { get; set; }
        public string VdCost { get; set; }
        public string VdNumberOfCopies { get; set; }
        public string VdPlot { get; set; }
        public string VdGenre { get; set; }


        public int RtId { get; set; }
        public string RtIssueDate { get; set; }
        public string RtReturnDate { get; set; }
    }
}
