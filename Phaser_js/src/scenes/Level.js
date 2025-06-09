/// Modificado por: Félix Hernández Muñoz-Yusta

// You can write more code here

/* START OF COMPILED CODE */

class Level extends Phaser.Scene {

	constructor() {
		super("Level");

		/* START-USER-CTR-CODE */
		// Write your code here.
		/* END-USER-CTR-CODE */
	}

	/** @returns {void} */
	editorCreate() {

		// map
		const map = this.add.tilemap("Map");
		map.addTilesetImage("terrain", "tileset");

		// Key_D
		const key_D = this.input.keyboard.addKey(Phaser.Input.Keyboard.KeyCodes.D);

		// Key_A
		const key_A = this.input.keyboard.addKey(Phaser.Input.Keyboard.KeyCodes.A);

		// Key_R
		const key_R = this.input.keyboard.addKey(Phaser.Input.Keyboard.KeyCodes.R);

		// Key_Space
		const key_Space = this.input.keyboard.addKey(Phaser.Input.Keyboard.KeyCodes.SPACE);

		// background
		const background = this.add.image(613, 354, "background");
		background.scaleX = 3;
		background.scaleY = 3;

		// tile
		const tile = map.createLayer("Tile Layer 1", ["terrain"], 224, 264);
		tile.scaleX = 1.5;
		tile.scaleY = 1.5;

		// player
		const player = this.add.sprite(262, 594, "idle_spritesheet", 0);
		player.scaleX = 1.5;
		player.scaleY = 1.5;
		player.play("player_idle");

		// UI
		const uI = this.add.text(232, 82, "", {});
		uI.text = "Movement: A, D, Space\nReset: R";

		this.map = map;
		this.key_D = key_D;
		this.key_A = key_A;
		this.key_R = key_R;
		this.key_Space = key_Space;

		this.events.emit("scene-awake");
	}

	/** @type {Phaser.Tilemaps.Tilemap} */
	map;
	/** @type {Phaser.Input.Keyboard.Key} */
	key_D;
	/** @type {Phaser.Input.Keyboard.Key} */
	key_A;
	/** @type {Phaser.Input.Keyboard.Key} */
	key_R;
	/** @type {Phaser.Input.Keyboard.Key} */
	key_Space;

	/* START-USER-CODE */
	create() {

		this.editorCreate();
	}

	update() {
	}


	/* END-USER-CODE */
}

/* END OF COMPILED CODE */

// You can write more code here
