embedded_components {
  id: "sprite"
  type: "sprite"
  data: "default_animation: \"Wallpaper\"\nmaterial: \"/builtins/materials/sprite.material\"\ntextures {\n  sampler: \"texture_sampler\"\n  texture: \"/main/sources/Wallpaper.atlas\"\n}\n"
  position {
    x: 143.0
    y: 198.0
  }
}
embedded_components {
  id: "label"
  type: "label"
  data: "size {\n  x: 128.0\n  y: 32.0\n}\npivot: PIVOT_W\ntext: \"Movement: A, D, Space\\n\"\n  \"Reset: R\"\nfont: \"/builtins/fonts/default.font\"\nmaterial: \"/builtins/fonts/label-df.material\"\n"
  position {
    x: 3.0
    y: 286.0
    z: 0.1
  }
  scale {
    x: 0.5
    y: 0.5
  }
}
