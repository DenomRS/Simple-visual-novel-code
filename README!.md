This are simple scripts to make a simple visual novel.
Here is the set up of each script and how each one works.
ALL use the Unity UI.

Scripts by DenomRS

----------------------------------------
SLIDESHOW SCRIPT
This script passes images with text.

1.- Create an empty canvas and add these gameobjects:
	Sprite
	Text box (optional)
	Text
	Button to see the next slide
	Button to finish or change scene

2.- Add this script to the canvas and drag and drop each gameobject.
3.- Set upin the inspector the total number of slides and texts (they must have the same number).
4.- Set up the typing speed. The lower, the faster
5.- The "scenebutton" can be any gameobject. Get creative if you don´t want to change scene.

---------------------------------------
PATH SCRIPT
The idea for this script is to have several UI canvas with the "slideshow" in one scene and setting them to active and
innactive. For it to happen, you add a gameobject with several choices as the "scenebutton" at the end
of the "slideshow" script. The "path" script is to set as innactive the canvas it is coming from and set
as active the new one.

1.- Create a game object with options and add this script.
2.- Add the canvas the previous gameobject in the "root" variable.
3.- Add the new canvas to the "choice" variable.


---------------------------------------
INSPECT SCRIPT
This is allows you to see closely to an object.

1.-Create and empty canvas and add objects you want to look close to.
2.-Add a transpatent button over the object you want to inspect.
3.-Create a game object with the image of the close up of the object, anything else you want and the default button script.
4.-Add this script to the transparent button and the close up gameobject.
5.-Drag and drop the close up object in "inspectwindow".
6.-Add the "enable" function to the transparent button and the "disable" function to the close up gameobject.

--------------------------------------

LEVELS SCRIPT
This one is only to change levels but it must be in every scene because of the loading screen

1.-Create an empty canvas.
2.-Add a sprite, a slider, and anything else you want.
3.-Set the canvas to "innactive".
4.-Add this script to any gameobject
5.-Drag and drop each gameobject to the correct variable.
6.-Add the correct functions to your buttons.

   
