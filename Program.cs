using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Football team1 = new Football("FC Barcelona", "La Liga", 1);
            Football team2 = new Football("Real Madrid CF", "La Liga", 2);
            Football team3 = new Football("Real Sociedad", "", 3);
            Football team4 = new Football("Atlético de Madris", "", 4);
            Football team5 = new Football("Real Betis Balompié", "", 5);

            Football team6 = new Football("Arsenal F.C.", "Premier League", 1);
            Football team7 = new Football("Manchester City F.C.", "Premier Leage", 2);
            Football team8 = new Football("Manchester United F.C.", "Premier League", 3);
            Football team9 = new Football("Tottenham Hotspur F.C.", "Premier League", 4);
            Football team10 = new Football("Newcastle United F.C.", "Premier League", 5);

            Football team11 = new Football("Paris Saint-Germain F.C.", "League 1", 1);
            Football team12 = new Football("Olympique de Marseille", "League 1", 2);
            Football team13 = new Football("AS Monaco", "League 1", 3);
            Football team14 = new Football("RC Lens", "League 1", 4);
            Football team15 = new Football("Stade Rennais F.C.", "League 1", 5);

            Football team16 = new Football("FC Bayern Munich", "Bundesliga", 1);
            Football team17 = new Football("Borussia Dortmund", "Bundesliga", 2);
            Football team18 = new Football("FC Union Berlin", "Bundesliga", 3);
            Football team19 = new Football("RB Leipzig", "Bundesliga", 4);
            Football team20 = new Football("SC Freiburg", "Bundesliga", 5);


            Console.WriteLine(team2.IsSecond());

        }
    }
}
