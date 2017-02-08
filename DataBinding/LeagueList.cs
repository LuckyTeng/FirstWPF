using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DataBinding
{
    public class Team
    {
        public string Name { get; set; }
    }
    public class Teams :ObservableCollection<Team>
    {
        
    }
    public class Division
    {
        public string Name { get; set; }
        public Teams Teams { get; set; }
    }

    public class Divisions :ObservableCollection<Division>
    {
        
    }

    public class League
    {
        public string Name { get; set; }
        public Divisions Divisions { get; set; }
    }

    public class LeagueList : ObservableCollection<League>
    {
        public LeagueList()
        {
            League a = new League();
            a.Name = "League A";
            a.Divisions = new Divisions();
            a.Divisions.Add(new Division() {Name = "Division A"});
            a.Divisions.Add(new Division() { Name = "Division B" });
            a.Divisions.Add(new Division() { Name = "Division C" });

            a.Divisions[0].Teams = new Teams();
            a.Divisions[0].Teams.Add(new Team() {Name = "Team Diamond"});
            a.Divisions[0].Teams.Add(new Team() { Name = "Team Heart" });
            a.Divisions[0].Teams.Add(new Team() { Name = "Team Club" });
            a.Divisions[0].Teams.Add(new Team() { Name = "Team Spade" });

            a.Divisions[1].Teams = new Teams();
            a.Divisions[1].Teams.Add(new Team() { Name = "Team Diamond" });
            a.Divisions[1].Teams.Add(new Team() { Name = "Team Heart" });
            a.Divisions[1].Teams.Add(new Team() { Name = "Team Club" });
            a.Divisions[1].Teams.Add(new Team() { Name = "Team Spade" });

            a.Divisions[2].Teams = new Teams();
            a.Divisions[2].Teams.Add(new Team() { Name = "Team Diamond" });
            a.Divisions[2].Teams.Add(new Team() { Name = "Team Heart" });
            a.Divisions[2].Teams.Add(new Team() { Name = "Team Club" });
            a.Divisions[2].Teams.Add(new Team() { Name = "Team Spade" });

            this.Add(a);

            League b = new League();
            b.Name = "League B";
            this.Add(b);
        }
    }
}
