namespace Hexeract.Component.StatusEffects
{
    struct Time
    {
        int InitialTime { get; }
        int RemainingTime { get; set; }
    }
    struct Level
    {
        int StatusLevel { get; }
    }
    struct StatusSpeed
    {
        string Id { get => "minecraft:speed"; }
    }
    struct StatusSlowness
    {
        string Id { get => "minecraft:slowness"; }
    }
    struct StatusHaste
    {
        string Id { get => "minecraft:haste"; }
    }
    struct StatusMiningFatigue 
    {
        string Id { get => "minecraft:mining_fatigue"; }
    }
    struct StatusStrength
    {
        string Id { get => "minecraft:strength"; }
    }
    struct StatusInstantHealth 
    {
        string Id { get => "minecraft:instant_health"; }
    }
    struct StatusInstantDamage
    {
        string Id { get => "minecraft:instant_damage"; }
    }
    struct StatusJumpBoost
    {
        string Id { get => "minecraft:jump_boost"; }
    }
    struct StatusNausea
    {
        string Id { get => "minecraft:nausea"; }
    }
    struct StatusRegeneration
    {
        string Id { get => "minecraft:regeneration"; }
    }
    struct StatusResistance
    {
        string Id { get => "minecraft:resistance"; }
    }
    struct StatusFireResistance
    {
        string Id { get => "minecraft:fire_resistance"; }
    }
    struct StatusWaterBreathing
    {
        string Id { get => "minecraft:water_breathing"; }
    }
    struct StatusInvisibility
    {
        string Id { get => "minecraft:invisibility"; }
    }
    struct StatusBlindness
    {
        string Id { get => "minecraft:blindness"; }
    }
    struct StatusNightVision
    {
        string Id { get => "minecraft:night_vision"; }
    }
    struct StatusHunger
    {
        string Id { get => "minecraft:hunger"; }
    }
    struct StatusWeakness
    {
        string Id { get => "minecraft:weakness"; }
    }
    struct StatusPoison
    {
        string Id { get => "minecraft:poison"; }
    }
    struct StatusWither
    {
        string Id { get => "minecraft:wither"; }
    }
    struct StatusHealthBoost
    {
        string Id { get => "minecraft:health_boost"; }
    }
    struct StatusAbsorption
    {
        string Id { get => "minecraft:absorption"; }
    }
    struct StatusSaturation
    {
        string Id { get => "minecraft:saturation"; }
    }
    struct StatusGlowing
    {
        string Id { get => "minecraft:glowing"; }
    }
    struct StatusLevitation
    {
        string Id { get => "minecraft:levitation"; }
    }
    struct StatusLuck
    {
        string Id { get => "minecraft:luck"; }
    }
    struct StatusBadLuck 
    {
        string Id { get => "minecraft:bad_luck"; }
    }
    struct StatusSlowFalling
    {
        string Id { get => "minecraft:slow_falling"; }
    }
    struct StatusConduitPower
    {
        string Id { get => "minecraft:conduit_power"; }
    }
    struct StatusDolphinsGrace
    {
        string Id { get => "minecraft:dolphins_grace"; }
    }
    struct StatusBadOmen
    {
        string Id { get => "minecraft:bad_omen"; }
    }
}