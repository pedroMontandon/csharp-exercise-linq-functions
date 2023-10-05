using System.Linq;

namespace TrybeGames;

public class TrybeGamesDatabase
{
    public List<Game> Games = new List<Game>();

    public List<GameStudio> GameStudios = new List<GameStudio>();

    public List<Player> Players = new List<Player>();

    public List<Game> GetGamesDevelopedBy(GameStudio gameStudio)
    {
        return (from game in Games
               where game.DeveloperStudio == gameStudio.Id
               select game).ToList();
    }

    public List<Game> GetGamesPlayedBy(Player player)
    {
        return (from game in Games
               where game.Players.Contains(player.Id)
               select game).ToList();
    }

    public List<Game> GetGamesOwnedBy(Player playerEntry)
    {
        return (from game in Games
               where playerEntry.GamesOwned.Contains(game.Id)
               select game).ToList();
    }


    public List<GameWithStudio> GetGamesWithStudio()
    {
        return (from game in Games
               join studio in GameStudios on game.DeveloperStudio equals studio.Id
               select new GameWithStudio
               {
                   GameName = game.Name,
                   StudioName = studio.Name,
                   NumberOfPlayers = game.Players.Count
               }).ToList();                   
    }
    
    public List<GameType> GetGameTypes()
    {
        return (from game in Games
               select game.GameType).Distinct().ToList();
    }

    // 9. Crie a funcionalidade de buscar todos os estúdios de jogos junto dos seus jogos desenvolvidos com suas pessoas jogadoras
    public List<StudioGamesPlayers> GetStudiosWithGamesAndPlayers()
    {
        // Implementar
        throw new NotImplementedException();
    }

}
