using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace OOPS.Collection
{
    class AQ4
    {

        int playerid;
        string playername, country, team;
       
        
        public AQ4(int playerid, string playername, string country, string team)
        {
            this.Playerid = playerid;
            this.Playername = playername;
            this.Country = country;
            this.Team = team;
        }

        public int Playerid { get => playerid; set => playerid = value; }
        public string Playername { get => playername; set => playername = value; }
        public string Country { get => country; set => country = value; }
        public string Team { get => team; set => team = value; }
    
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList()
            { "pune","pune","nashik"," pune","nashik","pune"};
            Hashtable h = new Hashtable();
            foreach(dynamic i in ar)
            {
                if (h.ContainsKey(i))//coatinskey is foe serach partucaular element there or not.

                {
                    int oldval = h[i];
                    h[i] = oldval + 1;
                } 
                else
                    h.Add(i, 1);
            }

            ArrayList al = new ArrayList();
            al.Add(new AQ4(1, "dhoni", "India", "csk"));
            al.Add(new AQ4(2, "Rohit", "India", "mi"));
            al.Add(new AQ4(3, "v.kolhi", "India", "rcb"));
            al.Add(new AQ4(4, "hardik", "India", "gt"));
            al.Add(new AQ4(5, "maxwell", "austrlia", "rcb"));
            al.Add(new AQ4(6, "arol", "India", "gt"));
            al.Add(new AQ4(7, "surya", "India", "mi"));
            al.Add(new AQ4(7, "fab dypli", "austrlia", "rcb"));
            string maxteamname = "";
            int maxcount = 0;
            foreach(AQ4 p in al)
            {
                string teamm=p.team;
                int c = 0;
                foreach(AQ4 pp in al)
                {
                    if (pp.team == teamm && pp.country == "austrlia")
                    {
                        c++;
                    }
                }
                if(maxcount<c)
                {
                    maxteamname = p.team;
                    maxcount = c; 
                }
            }

        }
    }
}
