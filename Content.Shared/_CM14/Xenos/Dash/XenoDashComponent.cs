using System.Numerics;
using Content.Shared.Damage;
using Content.Shared.FixedPoint;
using Robust.Shared.Audio;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared._CM14.Xenos.Dash;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(SharedXenoDashSystem))]
public sealed partial class XenoDashComponent : Component
{
    [DataField, AutoNetworkedField]
    public FixedPoint2 PlasmaCost = 40;

    [DataField, AutoNetworkedField]
    public float Range = 5;

    [DataField, AutoNetworkedField]
    public Vector2? Charge;
}
