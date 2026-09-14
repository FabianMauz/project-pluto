public class DefenceCannonShop {
    private DomainShip ship;
    private Shop shop;

    public DefenceCannonShop(DomainShip ship, Shop shop) {
        this.ship = ship;
        this.shop = shop;
    }

    public float getCostOfDamageUpgrade() {
        return ship.defenceCanon.getDamageUpgradeCosts() * shop.multiplier;
    }
    public float getCostOfAmountUpgrade() {
        return ship.defenceCanon.getAmountUpgradeCosts() * shop.multiplier;
    }
    public float getCostOfRangeUpgrade() {
        return ship.defenceCanon.getRangeUpgradeCosts() * shop.multiplier;
    }
    public float getCostOfReloadSpeedUpgrade() {
        return ship.defenceCanon.getReloadSpeedUpgradeCosts() * shop.multiplier;
    }

    public bool isDamageAffordable() {
        return ship.resources >= getCostOfDamageUpgrade();
    }
    public bool isRangeAffordable() {
        return ship.resources >= getCostOfRangeUpgrade();
    }
    public bool isReloadspeedAffordable() {
        return ship.resources >= getCostOfReloadSpeedUpgrade();
    }
    public bool isAmountAffordable() {
        return ship.resources >= getCostOfAmountUpgrade();
    }
    public void upgradeDamage() {
        if (ship.defenceCanon.isDamageUpgradable() && isDamageAffordable()) {
            ship.spentResources(getCostOfDamageUpgrade());
            shop.increaseMultiplier();
            ship.defenceCanon.upgradeDamage();
        }
    }
    public void upgradeRange() {
        if (ship.defenceCanon.isRangeUpgradable() && isRangeAffordable()) {
            ship.spentResources(getCostOfRangeUpgrade());
            shop.increaseMultiplier();
            ship.defenceCanon.upgradeRange();
        }
    }
    public void upgradeAmount() {
        if (ship.defenceCanon.isAmountUpgradable() && isAmountAffordable()) {
            ship.spentResources(getCostOfAmountUpgrade());
            shop.increaseMultiplier();
            ship.defenceCanon.upgradeAmount();
        }
    }
    public void upgradeReloadSpeed() {
        if (ship.defenceCanon.isReloadSpeedUpgradable() && isReloadspeedAffordable()) {
            ship.spentResources(getCostOfReloadSpeedUpgrade());
            shop.increaseMultiplier();
            ship.defenceCanon.upgradeReloadSpeed();
        }
    }
}
