using _20Full.DataAccess;
using _20Full.Models;
using _20Full.Models.Enums;
using Helpers;
using System.Collections.Generic;
using System.Linq;

namespace _20Full
{
    class Program20
    {
        static IDataSource dataSource = new JsonDataSource();

        static void Main(string[] args)
        {
            CreateHand();
            var hands = dataSource.LoadHands();

            var results = GetFulls(hands);

            foreach (var result in results)
            {
                System.Console.WriteLine(result);
            }

            ConsoleTools.CloseProgram();
        }

        private static List<Hand> GetFulls(List<Hand> hands)
        {
            var result = hands.
                Where(c => c.Cards.
                    GroupBy(x => x.Value).
                    Count() == 2).
                ToList();

            return result;
        }

        static void CreateHand()
        {
            var hands = new List<Hand>() {
            new Hand()
            {
                Cards = new Card[]
                {
                    new Card(){Pattern=CardPatterns.Clover, Value=2},
                    new Card(){Pattern=CardPatterns.Pike, Value=3},
                    new Card(){Pattern=CardPatterns.Tile, Value=2},
                    new Card(){Pattern=CardPatterns.Pike, Value=2},
                    new Card(){Pattern=CardPatterns.Clover, Value=3}
                }
            },
            new Hand()
            {
                Cards = new Card[]
                {
                    new Card(){Pattern=CardPatterns.Clover, Value=2},
                    new Card(){Pattern=CardPatterns.Pike, Value=3},
                    new Card(){Pattern=CardPatterns.Tile, Value=4},
                    new Card(){Pattern=CardPatterns.Pike, Value=5},
                    new Card(){Pattern=CardPatterns.Clover, Value=6}
                }
            },
            new Hand()
            {
                Cards = new Card[]
                {
                    new Card(){Pattern=CardPatterns.Clover, Value=9},
                    new Card(){Pattern=CardPatterns.Pike, Value=9},
                    new Card(){Pattern=CardPatterns.Tile, Value=10},
                    new Card(){Pattern=CardPatterns.Pike, Value=10},
                    new Card(){Pattern=CardPatterns.Heart, Value=9}
                }
            },
            new Hand()
            {
                Cards = new Card[]
                {
                    new Card(){Pattern=CardPatterns.Clover, Value=2},
                    new Card(){Pattern=CardPatterns.Pike, Value=6},
                    new Card(){Pattern=CardPatterns.Tile, Value=7},
                    new Card(){Pattern=CardPatterns.Pike, Value=11},
                    new Card(){Pattern=CardPatterns.Clover, Value=5}
                }
            }
            };

            dataSource.SaveHands(hands);
        }
    }
}
