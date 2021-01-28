namespace Programmierkurs2
{
    public class CdStop : Command
    {
        private readonly CdPlayer player;

        public CdStop(CdPlayer player)
        {
            this.player = player;
        }

        public override void execute()
        {
            player.Stop();
        }
    }
}