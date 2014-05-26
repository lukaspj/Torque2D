if (!isObject(ButtonBehavior))
{
    %template = new BehaviorTemplate(ButtonBehavior);
}

//-----------------------------------------------------------------------------

function ButtonBehavior::onTouchUp(%this, %touchID, %worldPosition)
{
   $SelectedTurretType = %this.TowerType;
}