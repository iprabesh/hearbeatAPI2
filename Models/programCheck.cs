using System;

namespace heartBeatServerAPI.Models
{
    public class programCheck
    {
        public int Id {get; set;}
        public string programName{get; set;}
        public int programCount{get; set;}
        public int programLimit { get; set;}

       /*  public programCheck(int Id, string programName, int programCount,int programLimit){
            this.Id = Id; 
            this.programName = programName;
            this.programCount = programCount;
            this.programLimit = 2;

        } */
    }
}