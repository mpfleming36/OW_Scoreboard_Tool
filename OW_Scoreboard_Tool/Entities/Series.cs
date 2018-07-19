using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OW_Scoreboard_Tool.Entities
{
    public class Series
    {
        #region Properties
        private string _name;
        private Team _home;
        private Team _away;
        private List<Map> _maps;
        private string _homeScore;
        private string _awayScore;

        public string Name { get => _name; set => _name = value; }
        public Team Home { get => _home; set => _home = value; }
        public Team Away { get => _away; set => _away = value; }
        public List<Map> Maps { get => _maps; set => _maps = value; }
        public string HomeScore { get => _homeScore; set => _homeScore = value; }
        public string AwayScore { get => _awayScore; set => _awayScore = value; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Series()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="home"></param>
        /// <param name="away"></param>
        /// <param name="maps"></param>
        /// <param name="homeScore"></param>
        /// <param name="awayScore"></param>
        public Series(string name, Team home, Team away, List<Map> maps, string homeScore, string awayScore)
        {
            _name = name;
            _home = home;
            _away = away;
            _maps = maps;
            HomeScore = homeScore;
            AwayScore = awayScore;
        }
        #endregion

        public void printAll()
        {
            Console.Out.WriteLine("Series name: " + _name);
            Console.Out.WriteLine("Team 1: " + _home.Name);
            Console.Out.WriteLine("Score: " + _homeScore);
            foreach (Player player in _home.Players)
            {
                Console.Out.WriteLine("Player: " + player.Name);
                Console.Out.WriteLine("Hero: " + player.Heroes[0].Name);
                Console.Out.WriteLine("Role: " + player.Role.Name);
            }
            Console.Out.WriteLine("Team 2: " + _away.Name);
            Console.Out.WriteLine("Score: " + _awayScore);
            foreach (Player player in _away.Players)
            {
                Console.Out.WriteLine("Player: " + player.Name);
                Console.Out.WriteLine("Hero: " + player.Heroes[0].Name);
                Console.Out.WriteLine("Role: " + player.Role.Name);
            }
            Console.Out.WriteLine("Maps: ");
            foreach (Map map in _maps)
            {
                Console.Out.WriteLine("Map: " + map.Name);
                Console.Out.WriteLine("Gametype: " + map.Gametype.Name);
                Console.Out.WriteLine("Home Score: " + map.HomeScore);
                Console.Out.WriteLine("Away Score: " + map.AwayScore);
            }
        }
    }
}
