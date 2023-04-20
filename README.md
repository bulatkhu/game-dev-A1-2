1) #### Design (4 Points)
   Create at least two characters per group member. A character consists of multiple primitive shapes with different colors. Use a parent GameObject to hold the individual parts.
   Create at least five different objects per group member (e.g. houses, trees, boxes) out of multiple primitive shapes.
   Build a world out of your objects and characters. Then place a border around your world using four Square sprites. The background color of your game can be changed on the Main Camera.
   [Hard] Change the sorting order of all characters and objects, so that:
   There are multiple objects that are in front of the characters.
   There are multiple objects that are behind the characters.
   The characters are sorted correctly among themselves (e.g. it shouldn't happen that some body parts are behind other characters while some are in front).

2) #### Creating the Player (4 Points)
   Choose one of your characters for the player to control. Implement a script that smoothly moves the player in all directions with W/A/S/D. The camera should follow the player.
   Pressing Shift changes the player's move speed. It should toggle between three different speeds in this order: 100% (default speed) → 200% → 400%. Afterwards it loops back to 100%.
   Pressing F changes all individual parts of the player character to a random color. You can use the function Random.ColorHSV() and its overloads for this.
   [Hard] The player can switch between all of your different characters using the number keys. Make sure that Shift and F still work.
 

   
   #### Submission and Feedback (2 Points)
   Share your game in the Moodle forum 2D World (A1) as a group. If you need to change something, please edit the post instead of replying to your own thread. Your submission has to include:
   A link to a working WebGL build. A tutorial can be found in the Moodle course under 'How to share your game'.
   The names of everyone in your group.
   A description of who worked on what. An example post (including example feedback) can be found at the top of the forum. For this exercise, please post:
   Screenshots of your characters and objects. Note who created which ones.
   A short description on who created which part of the world.
   (Optional) Any kind of additional notes others might need to know (e.g. controls, where to find things).
   After posting your game, please wait until the deadline (April 30th) before posting feedback. This is to prevent the first submissions from getting all of the replies, and to give everyone the chance to still fix bugs and add features until the end. The feedback for this exercise should be posted between May 1st and May 25th, which will also be the end of the next block.
   To get your feedback points, you have to reply to two other submissions (1P per feedback). You can give feedback to more than two submissions, in which case we will only grade your first two posts. To receive the full amount of points, your feedback needs to be written out in full sentences instead of bullet points. Furthermore, the feedback needs to specifically be directed at the submitted game. Generic feedback that would fit anything won't be enough. Play the game and make a few notes on what you liked and what didn't work so well. The target should be around 2-3 paragraphs (~200 words). Giving feedback is optional, but will make up 16% of the total grade (2% per exercise).
