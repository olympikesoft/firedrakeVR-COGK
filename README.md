# firedrakeVR-COGK
Repository for all things related to the Crytps of the Golem King
So, This script is needed for requirments for checkin to the Oculus store.  This is for a Oculus Mobile VR app (and then Rift)

Dev enviroment:  Unity 5.4.6      OVR 1.13    Build target android api 6 or above.   Targetting S7 or faster devices.
Unity assests used:  RealistFPS; RFPS game saver by pixel crushers.


The app needs to check the connection to a bluetooth controller at 
launch of app, on any pause /resart or on the load of a saved game.

I have the script working for check on startup, but am unsure on how to set up the logic for the other two requirments.

Script logic is as follows:
app loads.  Splash screen for first level plays.  
Script is attached to this scene (splash screen) in Unity.  Splash screen should play a number of seconds (about 6)  the if contoller is present, loads the next playable level associated with the splash screen. 
If no controller is present, then script loads a secondary Unity scene, made up of a canvas group that displays a graphic notifing the player that a controller is not present and then quits the app.

This script need to be able to check controller state for any of the three game states, without causeingany undue preformance hit on mobile.

Errors:
I have the script running  at startup but am getting compile errors when I try to add the scene transition (fade into scene after aprox six seconds of displaying the splashscreen.) when controller is present.


Overview of game logic

game is made up of five playable levels and five intro screens.   Intro scen for each level will play once for six seconds and then fade into /load the playable level.    

game is automatically saved when player takes off headset and  quites and will restart at the begining of whatever level the player was playing when they took off the headset.
game can puase at the exzact point in the level when player pauses game or removes headset, if player puts headset back on or unpuases then game play is picked up exactly where they left off in the level.

Game preformance is key and  app MUST maintain a 60FPS rate at all times.  So adding this check to the UPDATE() loop seems like it will incure a preformance cost.
