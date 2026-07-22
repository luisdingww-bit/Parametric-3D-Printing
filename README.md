# Parametric-3D-Printing 🖨️🏗️

> Computational geometry and digital fabrication experiments.

---

## Overview

Exploring the integration of parametric design and 3D printing for architectural components. This repository documents the workflow from digital design to physical fabrication.

---

## Workflow

```
┌─────────────────┐
│   Grasshopper   │
│  Parametric Dsg │
└────────┬────────┘
         ▼
┌─────────────────┐
│     Rhino       │
│  3D Modeling    │
└────────┬────────┘
         ▼
┌─────────────────┐
│  Export to STL  │
└────────┬────────┘
         ▼
┌─────────────────┐
│  Slicing (Cura) │
└────────┬────────┘
         ▼
┌─────────────────┐
│   3D Printer    │
│  Physical Part  │
└─────────────────┘
```

---

## Repository Structure

```
Parametric-3D-Printing/
├── README.md
├── Grasshopper/       ← .gh definition files
│   ├── wall_generator.gh
│   ├── facade_pattern.gh
│   └── structure_optimizer.gh
├── STL/               ← Export models for printing
│   ├── component_v01.stl
│   └── connector_v01.stl
├── Photos/            ← Process documentation
│   ├── printing_process.jpg
│   └── final_component.jpg
└── Research/          ← Notes and references
```

---

## Projects

### 🧱 Parametric Wall System
- Grasshopper-based wall panel generator
- Variable density and pattern control
- Structural optimization integration

### 🔗 Modular Connector
- 3D-printed joinery for timber structures
- Topology-optimized geometry
- Snap-fit assembly design

---

## Equipment & Settings

| Parameter | Setting |
|---|---|
| Printer | Bambu Lab X1C |
| Material | PLA / PETG |
| Layer Height | 0.2mm |
| Infill | 20% |
| Nozzle | 0.4mm |

---

## License

MIT

---

## Contact

**Louis** — [luisdingww@gmail.com](mailto:luisdingww@gmail.com)
