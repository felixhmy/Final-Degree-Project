components {
  id: "player"
  component: "/scripts/player.script"
}
embedded_components {
  id: "sprite"
  type: "sprite"
  data: "default_animation: \"player_idle\"\nmaterial: \"/builtins/materials/sprite.material\"\nsize {\n  x: 30.0\n  y: 38.0\n}\ntextures {\n  sampler: \"texture_sampler\"\n  texture: \"/main/sources/player_anim.atlas\"\n}\n"
}
embedded_components {
  id: "collisionobject"
  type: "collisionobject"
  data: "type: COLLISION_OBJECT_TYPE_KINEMATIC\nmass: 0.0\nfriction: 0.1\nrestitution: 0.5\ngroup: \"player\"\nmask: \"ground\"\nembedded_collision_shape {\n  shapes {\n    shape_type: TYPE_BOX\n    position {\n    }\n    rotation {\n    }\n    index: 0\n    count: 3\n  }\n  data: 10.0\n  data: 19.0\n  data: 10.0\n}\n"
}
