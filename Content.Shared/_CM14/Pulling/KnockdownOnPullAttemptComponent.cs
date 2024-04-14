﻿using Robust.Shared.GameStates;

namespace Content.Shared._CM14.Pulling;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class KnockdownOnPullAttemptComponent : Component
{
    [DataField, AutoNetworkedField]
    public TimeSpan Duration = TimeSpan.FromSeconds(8);
}
