# SCP1162 (EXILED)
An EXILED plugin which adds SCP-1162 into Scp-173 chamber in the LCZ.
![alt text](https://github.com/Marikider/SCP1162/blob/main/image.png?raw=true)

# Installation
1. Download the latest release from this repo
2. Put the plugin into the `.config/EXILED/Plugins` folder

# Config

This is the default configuration, you can change any of the values to your liking
```yaml
Scp-1162:
  is_enabled: true
  debug: true
  # Should a user get damaged when interacting with Scp-1162 without holding an item in hand
  should_damage: true
  # Message sent when interacting with Scp-1162 without holding an item in hand
  damage_hint: '<color=red>Dont stick your Hand in unknown holes ( ͡° ͜ʖ ͡° )</color>'
  # Minimum Health to use Scp-1162
  health_minus: 15
  # Message sent when interacting with Scp-1162
  interaction_hint: '<i>You put an item into </i><color=yellow>SCP-1162</color><i> and got Another!</i>'
  # The chance that the item disappears in % (set to 0 to disable)
  percent_disappearing: 40
  # Message sent when the item disappears
  lost_item_hint: '<color=red>You lost your item</color>'
  # What items should Scp-1162 be able to give
  items_to_give:
  - KeycardO5
  - SCP500
  - KeycardMTFOperative
  - GunCOM15
  - SCP207
  - Adrenaline
  - GunCOM18
  - KeycardFacilityManager
  - Medkit
  - KeycardMTFCaptain
  - KeycardGuard
  - GrenadeHE
  - KeycardZoneManager
  - KeycardGuard
  - Radio
  - GrenadeFlash
  - KeycardScientist
  - KeycardJanitor
  - Coin
  - Flashlight
```
