using Smod2;
using Smod2.Attributes;
using scp4aiur;
namespace Finalbossdogs
{
	[PluginDetails(
		author = "Albertinchu",
		name = "Finalbossdogs",
		description = "2 perros con 3000 de vida",
		id = "albertinchu.gamemode.Finalbossdogs",
		version = "1.0.0",
		SmodMajor = 3,
		SmodMinor = 0,
		SmodRevision = 0
		)]
	public class Finalbossdogs : Plugin
	{

		public override void OnDisable()
		{
			this.Info("Finalbossdogs - Desactivado");
		}

		public override void OnEnable()
		{
			Info("Finalbossdogs - activado.");
		}

		public override void Register()
		{
			GamemodeManager.Manager.RegisterMode(this);
			Timing.Init(this);
			this.AddEventHandlers(new PlayersEvents(this));

		}
		
	}

}

