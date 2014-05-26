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
     TileBoard.selectSpriteId(getWord(%sprites, %i));
     TileBoard.setSpriteImageFrame($SelectedTurretType);
     TileBoard.deselectSprite();
   }
}