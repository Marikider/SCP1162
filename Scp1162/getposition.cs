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
    class GetPosition : ParentCommand
    {
        public override string Command { get; } = "getposition";

        public override string[] Aliases { get; } = { "gp" };

        public override string Description { get; } = "getposition";


        public override void LoadGeneratedCommands()
        {
        }

        protected override bool ExecuteParent(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player player = Player.Get(sender);
            List<string> args = arguments.ToList();
            Vector3 gpos= player.Position;
            Room room=Room.Get(player.Position);
            Vector3 lpos = player.Position - room.Position;
            response = "\nГлобальная Позиция: "+gpos.ToString()+"\n"+"Локальная Позиция: "+lpos.ToString()+"\n"+"Твоя Комната: "+room.Type.ToString();
            return true;
        }
    }
}
