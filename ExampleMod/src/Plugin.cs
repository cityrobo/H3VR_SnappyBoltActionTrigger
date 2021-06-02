using Deli.Setup;

namespace ExampleMod
{
	public class Plugin : DeliBehaviour
	{
		private readonly Hooks _hooks;

		public Plugin()
		{
			_hooks = new Hooks();
			_hooks.Hook();
		}

		private void OnDestroy()
		{
			_hooks?.Unhook();
		}
	}
}