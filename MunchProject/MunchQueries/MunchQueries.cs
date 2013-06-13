using MunchProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MunchProject.MunchQueries
{
    public static class MunchQueries
    {
        public static int GameId { get; set; }

        public static IQueryable<MunchModel> CurrentlyInPlay(this IQueryable<GameModel> data)
        {
            var id = GameId;
            var game = data.Where(p => p.Id == id).FirstOrDefault();

            if (game != null)
                return game.Munches;

            return null;
        }
    }
}