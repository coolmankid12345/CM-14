﻿using Robust.Shared.GameStates;

namespace Content.Shared._RMC14.Chemistry;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(SharedRMCChemistrySystem))]
public sealed partial class DetailedExaminableSolutionComponent : Component
{
    [DataField(required: true), AutoNetworkedField]
    public string Solution = string.Empty;
}
