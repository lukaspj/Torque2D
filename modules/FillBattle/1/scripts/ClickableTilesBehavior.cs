if (!isObject(ClickableTilesBehavior))
{
    %template = new BehaviorTemplate(ClickableTilesBehavior);
}

//-----------------------------------------------------------------------------

function ClickableTilesBehavior::onTouchUp(%this, %touchID, %worldPosition)
{
   %sprites = %this.owner.pickPoint(%worldPosition);
   
   %spriteCount = %sprites.count;
   
   if(%spriteCount == 0)
      return;
      
   for(%i = 0; %i < %spriteCount; %i++)
   {
      %this.owner.selectSpriteId(getWord(%sprites, %i));
      if(%this.owner.getSpriteImage() $= $SelectedTurretType.Image)
         %this.owner.setSpriteImageFrame($SelectedTurretType.Frame);
      else
         %this.owner.setSpriteImage($SelectedTurretType.Image, $SelectedTurretType.Frame);
      %this.owner.deselectSprite();
   }
}