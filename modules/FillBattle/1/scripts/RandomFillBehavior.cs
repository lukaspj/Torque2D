if (!isObject(RandomFillBehavior))
{
   %template = new BehaviorTemplate(RandomFillBehavior);
   %template.addBehaviorField(GridSize, "The size of the board", int, 15);
}

//-----------------------------------------------------------------------------

function RandomFillBehavior::onBehaviorAdd(%this)
{
   // Iterate over all the sprites
   for(%x = 0; %x < %this.GridSize; %x++)
   {
      for(%y = 0; %y < %this.GridSize; %y++)
      {
         // Pick a random number from 0 to 5.
         //  This will equal the frame number from the ImageAsset.
         %randomFrame = getRandom(0,5);
         
         // Add a sprite (aka "tile")
         %this.owner.addSprite(%x SPC %y);
         
         // Assign it an ImageAsset and a random frame
         %this.owner.setSpriteImage("FillBattle:SixColors", %randomFrame);
      }
   }
}