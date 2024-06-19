using Content.Shared.FixedPoint;
using Robust.Shared.Audio;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared._CM14.Xenos.Projectile.Spit.Spit;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(XenoSpitSystem))]
public sealed partial class XenoSpitComponent : Component
{
    [DataField, AutoNetworkedField]
    public FixedPoint2 PlasmaCost = 25;

    [DataField, AutoNetworkedField]
    public float Speed = 10;

    [DataField, AutoNetworkedField]
    public EntProtoId ProjectileId = "XenoSpitProjectile";

    [DataField, AutoNetworkedField]
    public SoundSpecifier Sound = new SoundCollectionSpecifier("XenoSpitAcid", AudioParams.Default.WithVolume(-10f));
}
