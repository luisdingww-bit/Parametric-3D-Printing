# Parametric-3D-Printing

Computational-geometry experiments for digital fabrication — parametric wall panels and their print settings.

> **Status: definition + config (partial).** The Grasshopper script and print profile are real; fabricated outputs (STL / photos) are to be added.

## What's here

- **`wall_generator.cs`** — a Grasshopper **C# script component** generating variable-density wall panels with sin / cos height variation.
- **`STL/print_settings.yaml`** — a complete **Bambu Lab X1C** print profile (PLA, gyroid infill, temps, supports).
- **`Research/material_notes.md`** — PLA / PETG / TPU print-test log.

## Honest notes

- No `.gh` definition file, exported **STL**, or **photos** are committed yet — the fabrication workflow is currently documentation + script only.
- To reproduce: load `wall_generator.cs` into a Grasshopper C# component, bake the panels, slice with the provided YAML profile.

## Tech

Grasshopper / Rhino C# scripting · YAML config

## License

MIT
