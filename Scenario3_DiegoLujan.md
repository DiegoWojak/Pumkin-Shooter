Scenario 3:
You’re deep in the middle of making what will surely be the greatest ARCore based 3D sticker
app the world has ever seen. At the morning stand up you hear that the sound designer has
made a pass updating the existing UI sound files while the art team have submitted 10 new 3D
sticker prefabs bringing the total to 250! Excited to see the new changes you rush back to your
desk and update. After making a new build you notice the size of the .apk has doubled in size,
far too big for the changes mentioned!
● Questions:
○ How do you go about figuring out the cause of the increase?
Answer:
Make a build then open the editor log and see the size of each assets and scene.

○ How will you inform the team of your findings?
Answer:
I would send an email with each assets with this information:
 The size of the assets in the log.
 The screenshot of the problem on Unity.

○ What steps do you take to reduce the size?
 Answer:
  For the image:
    I've attemp to use crunch compresion.
    Resize the image to be multiply of 4
  For the sounds:
    Reduce the quality of the sound.
    Change the format using external application.
  