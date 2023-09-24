using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using QueryBuilder;

namespace QueryBuilderStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            string dbPath = "C:\\Users\\maddu\\source\\repos\\QueryBuilder\\QueryBuilder\\Data\\data.db";

            using (QueryBuilderStarter.QueryBuilder query = new QueryBuilderStarter.QueryBuilder(dbPath))
            {
                query.DeleteAll<Pokemon>();
                Console.WriteLine("All pokemon deleted, your welcome!");

                query.DeleteAll<BannedGames>();
                Console.WriteLine("All BannedGames deleted, your welcome!");

                var pokemonCollection = new List<Pokemon>
                {
                    new Pokemon { Name = "Pikachu", Type1 = "Electric", Type2 = "None", Total = 318, HP = 45, Attack = 49, Defense = 49, SpAtk = 65, SpDef = 65, Speed = 45, Generation = 1 },
                    new Pokemon { Name = "Charizard", Type1 = "Fire", Type2 = "Flying", Total = 534, HP = 78, Attack = 84, Defense = 78, SpAtk = 109, SpDef = 85, Speed = 100, Generation = 1 }
                };
                Console.WriteLine("Just Created two Pokemon for your sorry ass!");

                var bannedGamesCollection = new List<BannedGames>
                {
                    new BannedGames { Title = "Assassin's Creed", Series = "Assassin's Creed", Country = "Saudi Arabia", Reason = "Was banned (for two weeks) because of perceived negative portrayal of Arabs" },
                    new BannedGames { Title = "Blood", Series = "Blood", Country = "Brazil", Reason = "Banned because of high impact violence" }
                };
                Console.WriteLine("Just Created two BannedGames for your fugly looking self!");

                foreach (var pokemon in pokemonCollection)
                {
                    query.Create(pokemon);
                }
                foreach (var bannedGame in bannedGamesCollection)
                {
                    query.Create(bannedGame);
                }
                var newPokemon = new Pokemon { Name = "Bulbasaur", Type1 = "Grass", Type2 = "Poison", Total = 318, HP = 45, Attack = 49, Defense = 49, SpAtk = 65, SpDef = 65, Speed = 45, Generation = 1 };
                query.Create(newPokemon);
                var newBannedGame = new BannedGames { Title = "Blood", Country = "Brazil", Reason = "Banned because of high impact violence" };
                query.Create(newBannedGame);
            }

            Console.WriteLine("Exit by clicking anything");
            Console.ReadKey();
        }
    }
}
