## Realizado por: Félix Hernandez Muñoz-Yusta

extends CharacterBody2D

# Macro que permite reducir el codigo:
@onready var animation: AnimatedSprite2D = $AnimatedSprite2D
@onready var gravity: float = ProjectSettings.get_setting("physics/2d/default_gravity")

@export var speed: float
@export var jumpSpeed: float

func _ready():
	animation.play("Idle")

func _process(delta):
	player_movement()
	player_jump()
	player_gravity(delta)
	player_reset()
	
	uptade_sprites()

func _physics_process(_delta):
	#Funcion pre-creada del CharacterBody2D para el movimiento:
	move_and_slide()


func uptade_sprites():
	if is_on_floor():
		return
	
	if velocity.y < 0:
		animation.play("Jump")
	else:
		animation.play("Landing")



func player_gravity(delta):
	if not is_on_floor():
		velocity.y += gravity * delta


func player_movement():
	# get_axis coje 2 acciones del input como si se moviera
	# en un eje es decir Left (negativo) y Right (positivo)
	# es decir (-1, 1)
	var horizontal = Input.get_axis("Left", "Right")
	
	if (horizontal != 0):
		velocity.x = speed * horizontal
		animation.play("Run")
		animation.flip_h = horizontal < 0
	else:
		velocity.x = 0.0
		animation.play("Idle")


func player_jump():
	if Input.is_action_just_pressed("Jump") and is_on_floor():
		velocity.y = -jumpSpeed

func player_reset():
	if Input.is_action_just_pressed("Reset"):
		position.x = -100
		position.y = 141
