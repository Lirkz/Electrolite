extends Node2D


# Called when the node enters the scene tree for the first time.
func _ready():
	$Area2D.body_entered.connect(self._play_animation)

func _play_animation(_body):
	$Area2D.body_entered.disconnect(self._play_animation)
	$AnimationPlayer.play('text')
