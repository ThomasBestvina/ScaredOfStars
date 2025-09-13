extends Node2D

var floor_layer = []
var object_layer = []
var ceiling_layer = []

@export var camera: Node2D

func _ready() -> void:
	# Initialize all layers with default values
	for x in range(Config.VIEWPORT_TILE_SIZE):
		var row = []
		for y in range(Config.VIEWPORT_TILE_SIZE):
			row.append([0, Color.WHITE])  # Default values
		
		floor_layer.append(row.duplicate())
		object_layer.append(row.duplicate())
		ceiling_layer.append(row.duplicate())

func update() -> void:
	pass
