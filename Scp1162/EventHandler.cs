using Exiled.API.Features;
using Exiled.Events.EventArgs;
using MEC;
using Respawning.NamingRules;
using Respawning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Random = UnityEngine.Random;
using Exiled.API.Enums;
using System.Numerics;
using Exiled.API.Features.Items;
using Mirror;
using System.Collections;
using Exiled.Events.EventArgs.Player;
using Exiled.Events.Handlers;
using InventorySystem.Items;
using CommandSystem.Commands.Console;
using Exiled.API.Features.Pickups;
using Exiled.API.Extensions;
using Exiled.API.Features.Roles;
using PlayerRoles;
using Exiled.API.Features.DamageHandlers;
using PlayerStatsSystem;
using System.Diagnostics;

namespace SCP1162
{
    public class EventHandler
    {
        public ushort Scp1162;
        public Vector3 GetGlobalCords(Vector3 localCords, Room room)
        {
            Quaternion rotation = room.Rotation;
            if (Math.Abs(rotation.eulerAngles.y - 0.0f) < 1.0)
                return new Vector3(room.Position.x + localCords.x, room.Position.y + localCords.y, room.Position.z + localCords.z);
            if (Math.Abs(rotation.eulerAngles.y - 90f) < 1.0)
                return new Vector3(room.Position.x + localCords.z, room.Position.y + localCords.y, room.Position.z - localCords.x);
           
            if (Math.Abs(rotation.eulerAngles.y - 180f) < 1.0)
                return new Vector3(room.Position.x - localCords.x, room.Position.y + localCords.y, room.Position.z - localCords.z);
            return Math.Abs((rotation).eulerAngles.y - 270f) < 1.0 ? new Vector3(room.Position.x - localCords.z, room.Position.y + localCords.y, room.Position.z + localCords.x) : new Vector3(111f, 222f, 333f);
        }
        public void SpawnScp1162()
        {
            Vector3 localPos = new Vector3(17f, 13.1f, 3f);
            Vector3 rot= new Vector3(90f, 1f, 0.0f);
            Room room = Room.Get(RoomType.Lcz173);
            Vector3 globalCords = GetGlobalCords(localPos, room);
            Quaternion rotation = room.Rotation;
            Quaternion quaternion = Quaternion.Euler(rot.x, rotation.eulerAngles.y + rot.y, rot.z);
            Pickup scp1162pick = Pickup.CreateAndSpawn(ItemType.SCP500, globalCords, quaternion);
            scp1162pick.Rigidbody.useGravity = false;
            scp1162pick.Rigidbody.detectCollisions = false;
            scp1162pick.Scale = new Vector3(10,10,10);
            Scp1162 = scp1162pick.Serial;


        }
        public void OnRoundStart()
        {
            SpawnScp1162();
        }
        public void PickingScp1162(PickingUpItemEventArgs ev)
        {

            if (Scp1162 == ev.Pickup.Serial)
            {
                if (ev.Player.CurrentItem != null)
                {
                    ev.Player.RemoveItem(ev.Player.CurrentItem);
                    ev.Player.AddItem(Plugin.plugin.Config.ItemsToGive.RandomItem());
                    ev.Player.ShowHint(Plugin.plugin.Config.InteraktingHint, 3);
                }
                else
                {
                    if (Plugin.plugin.Config.ShouldHeart)
                    {
                        ev.Player.Hurt(Plugin.plugin.Config.HealthMinus, DamageType.Custom);
                        ev.Player.EnableEffect(EffectType.Burned, 3);
                        ev.Player.ShowHint(Plugin.plugin.Config.HeartHint, 3);
                    }

                }
                ev.IsAllowed = false;
            }
        }
    }
}
