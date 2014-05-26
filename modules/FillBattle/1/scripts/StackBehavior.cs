if (!isObject(StackBehavior))
{
    %template = new BehaviorTemplate(StackBehavior);
}

//-----------------------------------------------------------------------------

function StackBehavior::onBehaviorAdd(%this)
{
    %this.owner.len = 0;
}

//-----------------------------------------------------------------------------

function StackBehavior::push(%this, %val)
{
    %this.owner.v[%this.owner.len] = %val;
    %this.owner.len++;
}

//-----------------------------------------------------------------------------

function StackBehavior::pop(%this)
{
    if (%this.owner.len == 0)
    {
        error("Stack Underflow");
        return;
    }

    %this.owner.len--;
    return %this.owner.v[%this.owner.len];
}