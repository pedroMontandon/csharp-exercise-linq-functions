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


    // 7. Crie a funcionalidade de buscar todos os jogos junto do nome do estúdio desenvolvedor
    public List<GameWithStudio> GetGamesWithStudio()
    {
        // Implementar
        throw new NotImplementedException();                      
    }
    
    // 8. Crie a funcionalidade de buscar todos os diferentes Tipos de jogos dentre os jogos cadastrados
    public List<GameType> GetGameTypes()
    {
        // Implementar
        throw new NotImplementedException();
    }

    // 9. Crie a funcionalidade de buscar todos os estúdios de jogos junto dos seus jogos desenvolvidos com suas pessoas jogadoras
    public List<StudioGamesPlayers> GetStudiosWithGamesAndPlayers()
    {
        // Implementar
        throw new NotImplementedException();
    }

}
