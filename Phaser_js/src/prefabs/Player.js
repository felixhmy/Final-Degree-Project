
// You can write more code here

/* START OF COMPILED CODE */

class Player extends Phaser.GameObjects.Sprite {

	constructor(scene, x, y, texture, frame) {
		super(scene, x ?? 78, y ?? 37, texture || "idle_spritesheet", frame ?? 0);

		scene.physics.add.existing(this, false);
		this.body.setOffset(12, 16);
		this.body.setSize(8, 16, false);

		// startAnimationScript
		const startAnimationScript = new StartAnimationScript(this);

		// startAnimationScript (prefab fields)
		startAnimationScript.animationKey = "player_idle";

		/* START-USER-CTR-CODE */

		this.scene.events.on("update", () => this.updatePlayer());

		/* END-USER-CTR-CODE */
	}

	/* START-USER-CODE */

	/**
	 * @return {Phaser.Physics.Arcade.Body} 
	 */
	getBody() {
		return this.body;
	}

	updatePlayer() {

	}

	/* END-USER-CODE */
}

/* END OF COMPILED CODE */

// You can write more code here
