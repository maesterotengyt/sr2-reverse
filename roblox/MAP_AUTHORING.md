# MAP AUTHORING (original stages)

Do **not** recreate the reference stages. Use their stats only as pacing/size guidance.

## Reference sizing (from `docs/maps`)
- Quantum world size 512 units; race stages are long horizontal courses broken into numbered sections (reference scene materials are organised Section01…Section10) with 2 layouts (A/B) each.
- Typical complexity: ~2,500-6,000 static 2D colliders per race layout (many are small slope pieces); big tutorial/test maps up to ~29k.
- Collider mix: mostly `Stage` layer solids + `ThinPlatform` (drop-through) + `Wall` (wall-slide surfaces) + `Ceiling` (hookable) + `TrapDoor`.
- Race stage target for v1: **length 250-400 units (750-1200 studs)**, 8-10 sections, 2 layouts, 2-3 vertical routes per section (fast risky vs slow safe).

## Design rules that make it play like a speed-platformer
1. **Hook anchors must exist**: continuous or periodic Ceiling-layer surfaces over key gaps; gaps sized so a hook-swing (rope ≈ 9-12 u) clears them but a run-jump (≈ 8 u horizontal) doesn't.
2. **Wall corridors** (vertical walls with normal ≥ 0.98) for wall-slide/wall-jump climbs; add ledges at the top (ledge climb).
3. **Slopes**: downhill ride sections reward sliding; uphill punish no-boost. Keep slope normal.y ≥ 0.6 to remain walkable (steeper = wall-ish/slide off).
4. **Boost economy**: put Boost Fillers so a full meter (100 @ 42/s ≈ 2.4 s of boost) covers the next hard gap; one Item Box cluster per section.
5. **Checkpoint every section**; blastzone logic assumes forward progress (no long backtrack loops).
6. **Readability**: strong silhouette, contrast for hazards, parallax background; foreground never overlaps the play plane.
7. 2-3 hazards per section max in v1 (spike, saw, laser, trap door, rocket launcher).

## Roblox build format
- `Workspace/Stages/<Name>/` Folder: `Geometry` (visual), `Collision` (invisible 2D-extruded Parts, CollisionGroup by layer), `Elements` (tagged Parts/Models with Attributes e.g. `Cooldown`, `Impulse`), `Spawns`, `Checkpoints` (ordered `Index` attribute), `Finish`, `Blastzone` (volume), `Camera` (bounds attribute).
- `StageLoader` validates: ≥1 spawn per player slot, contiguous checkpoint indices, a Finish, bounds present.
- Author layouts A/B as sibling folders swapped at match start.
