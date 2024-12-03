using FootballScoutManager.Code_Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;


[Serializable]

public class PlayerManager
{
    protected Dictionary<int, Player> players; //= new Dictionary<int, Player>();

    int listSize;

    public PlayerManager()
    {
        players = new Dictionary<int, Player>();
    }

    public Dictionary<int, Player> getPlayers()
    {
        return players;
    }
    public void addPlayer(Player player, params Object[] fields)
    {
        players.Add(player.Id, player);
        
    }

    public void removePlayer(int playerId)
    {
        players.Remove(playerId);
    }

    public void removeAllPlayers()
    {
        listSize = players.Count;
        for (int i=1; i<=listSize; i++)
        {
            removePlayer(i);
        }
    }

    public Player getPlayer(int playerId)
    {
        return players[playerId];
        
    }

    public string getPosition(Player player)
    {

        switch (player.GetType().Name)
        {
            case "GoalKeeper":
                return "Goalkeeper";
            case "Defender":
                return "Defender";
            case "MidFielder":
                return "Midfielder";
            case "Attacker":
                return "Attacker";
            default: throw new Exception("Not a valid player position.");
        }
    }

    public string getInfoAboutPlayer(Player player)
    {
        return  "Position: " + getPosition(player) + " |" + " Age: " + player.Age + " | Name:" + player.Name + " | OverAll Rating:" + player.Scout() + " | -> Is fit to your needs.";
    }

    public int getListSize()
    {
        return players.Count;
    }

}




