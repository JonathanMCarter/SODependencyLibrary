# Scriptable Object Dependency Library
*This README is still a work in progress, so the information displayed here is not complete.*

A library for using Scriptable Objects to reduce the dependenies for variables on scripts in Unity. This is a ideal 
for values such as health, ammo, or any variable that you want to get more than once but don't want to need instances 
of scrpits that are otherwise not needed in the scene you are in. 

This is very much based on the work mentioned in this Unite talk from 2017 which is well worth a watch. Click the image to see the video.

<a href="http://www.youtube.com/watch?feature=player_embedded&v=raQ3iHhE_Kk
" target="_blank"><img src="http://img.youtube.com/vi/raQ3iHhE_Kk/0.jpg" 
alt="IMAGE ALT TEXT HERE" width="560" height="350" border="10" /></a>

In essence, the system uses scriptable objects are the variable, as they can be changed at runtime, just not saved. 
We can get around the save issue with pretty much and save system in Unity, so this isn't really an issue. 
These are ideal when you need to reference a variable in multiple scripts but don't want the scripts to be dependent on each other.

For an example, say you have a player with health. You could need the use this variable for multiple scripts such as:
- The Player 
- The Health UI
- Enemies for damage
- Power ups
- Potions

You get the idea, could be needed in a lot of places. So instead of referencing the player script and getting the health that way, 
we instead use a reference. Say the player health is an int, so we'll use an IntReference. 

[TODO - Add Image Here]

..... more coming soon
