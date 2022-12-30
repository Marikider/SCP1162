using CommandSystem;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.CustomRoles.API.Features;
using Exiled.Permissions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace SCP1162
{

    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class Teleport : ParentCommand
    {
        public override string Command { get; } = "teleport";

        public override string[] Aliases { get; } = { "tp" };

        public override string Description { get; } = "teleport Cords";


        public override void LoadGeneratedCommands()
        {
        }

        protected override bool ExecuteParent(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player player = Player.Get(sender);
            List<string> args = arguments.ToList();
            Vector3 vector3;
            float x=float.Parse(args.ElementAt(0));
            float y = float.Parse(args.ElementAt(1));
            float z = float.Parse(args.ElementAt(2));
            vector3.x = x;
            vector3.y = y;
            vector3.z= z;
            player.Teleport(vector3);
            response = "ТЕЛЕПОРТ УХУХУ";
            return true;
        }
    }
}
