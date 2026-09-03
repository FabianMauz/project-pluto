public class ArmorShop {
    private DomainShip ship;
    private Shop shop;

    public ArmorShop(DomainShip ship, Shop shop) {
        this.ship = ship;
        this.shop = shop;
    }

    public float getCostOfValueUpgrade() {
        return ship.armor.getCostOfValueUpgrade() * shop.multiplier;
    }
    public float getCostOfReductionUpgrade() {
        return ship.armor.getCostOfReductionUpgrade() * shop.multiplier;
    }

    public bool isValueUpgradeAffordable() {
        return ship.resources >= getCostOfValueUpgrade();
    }
    public bool isRecutionUpgradeAffordable() {
        return ship.resources >= getCostOfReductionUpgrade();
    }

    public void upgradeValue() {
        if (ship.armor.isValueUpgradable() && isValueUpgradeAffordable()) {
            ship.spentResources(getCostOfValueUpgrade());
            shop.increaseMultiplier();
            ship.armor.upgradeValue();
        }
    }
    public void upgradeRecution() {
        if (ship.armor.isReductionUpgradable() && isRecutionUpgradeAffordable()) {
            ship.spentResources(getCostOfReductionUpgrade());
            shop.increaseMultiplier();
            ship.armor.upgadeReduction();
        }
    }

}
