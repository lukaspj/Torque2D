if(!isObject(CenterPositionBehavior))
{
   %template = new BehaviorTemplate(CenterPositionBehavior);
}

//-----------------------------------------------------------------------------

function CenterPositionBehavior::onAddToScene(%this, %scene)
{
   // Get the number of sprites in the composite.
   %count = %this.owner.getSpriteCount();
   %length = mSqrt(%count);
   
   %spriteSize = %this.owner.getDefaultSpriteSize();
   %boardSizeX = %length * %spriteSize.x;
   %boardSizeY = %length * %spriteSize.y;
   
   %x = (%boardSizeX / 2) - (%spriteSize.x / 2);
   %y = (%boardSizeY / 2) - (%spriteSize.y / 2);
   
   %this.owner.setPosition(-%x, -%y);
}