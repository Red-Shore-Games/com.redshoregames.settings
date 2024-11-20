namespace RedShoreGames.Settings
{
    public interface IGameData<out T>
    {
        T GetData();
    }
}