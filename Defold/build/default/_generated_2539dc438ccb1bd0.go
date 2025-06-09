components {
  id: "map"
  component: "/main/sources/map.tilemap"
}
embedded_components {
  id: "collisionobject"
  type: "collisionobject"
  data: "collision_shape: \"/main/sources/map.tilemap\"\ntype: COLLISION_OBJECT_TYPE_STATIC\nmass: 0.0\nfriction: 0.1\nrestitution: 0.5\ngroup: \"ground\"\nmask: \"player\"\n"
}
