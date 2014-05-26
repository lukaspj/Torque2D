if (!isObject(LevelFillBehavior))
{
   %template = new BehaviorTemplate(LevelFillBehavior);
   %template.addBehaviorField(GridSize, "The size of the board", int, 15);
   %template.addBehaviorField(LevelFile, "The level file", "default", "default.level.taml");
}

//-----------------------------------------------------------------------------

function LevelFillBehavior::onBehaviorAdd(%this)
{
   %this.Load();
}

function LevelFillBehavior::Save(%this)
{
   %Level = new SimGroup() {
      Size = %this.GridSize;
      Default = BlueCrystal;
   };
   %Positions = new SimGroup();
   %Level.add(%Positions);
   for(%x = 0; %x < %this.GridSize; %x++)
   {
      for(%y = 0; %y < %this.GridSize; %y++)
      {
         %point = new SimObject();
         %point.Position = %x SPC %y;
         %this.owner.SelectSprite(%point.Position);
         %image = %this.owner.getSpriteImage();
         %frame = %this.owner.getSpriteImageFrame();
         %found = false;
         for(%i = 0; %i < Tiles.getCount(); %i++)
         {
            %type = Tiles.getObject(%i);
            if(%type.Image $= %image
               && %type.Frame $= %frame)
               {
                  %point.Type = %type.getName();
                  %found = true;
                  break;
               }
         }
         if(!%found)
         {
            %point.Type = %Level.Default;
         }
         %Positions.add(%point);
      }
   }
   TamlWrite(%Level, %this.LevelFile);
}

function LevelFillBehavior::Load(%this)
{
   if(!isFile(%this.LevelFile))
    return;
   %level = TamlRead(%this.LevelFile);
   
   // Iterate over all the sprites
   for(%x = 0; %x < %level.Size; %x++)
   {
      for(%y = 0; %y < %level.Size; %y++)
      {
         // Pick a random number from 0 to 5.
         //  This will equal the frame number from the ImageAsset.
         %Tile = %level.getObject(0).getObject((%x*%level.Size)+%y);
         
         // Add a sprite (aka "tile")
         %this.owner.addSprite(%Tile.Position);
         
         // Assign it an ImageAsset and a random frame
         %this.owner.setSpriteImage(%Tile.Type.Image, %Tile.Type.Frame);
      }
   }
}