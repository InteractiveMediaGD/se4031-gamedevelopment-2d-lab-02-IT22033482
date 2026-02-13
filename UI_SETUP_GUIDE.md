# UI Setup Guide for Health and Score Display

## Step-by-Step Instructions

### Step 1: Verify Canvas Setup
1. In Hierarchy, check if **Canvas** exists
2. If Canvas exists, select it
3. In Inspector, verify:
   - **Render Mode**: Screen Space - Overlay
   - **Canvas Scaler**: Set to "Scale With Screen Size"
   - **Reference Resolution**: 1920 x 1080 (or your preferred resolution)

### Step 2: Create Health Text (Top Left)
1. Right-click on **Canvas** in Hierarchy → **UI** → **Text - TextMeshPro**
   - If prompted to import TMP Essentials, click **Import**
2. Rename it to **"HealthText"**
3. In Inspector, set **Rect Transform**:
   - **Anchor**: Top Left
   - **Position X**: 50
   - **Position Y**: -30
   - **Width**: 200
   - **Height**: 50
4. Set **TextMeshPro - Text (UI)** properties:
   - **Text**: "Health: 100"
   - **Font Size**: 36
   - **Alignment**: Left
   - **Color**: White (or your preferred color)

### Step 3: Create Score Text (Top Right)
1. Right-click on **Canvas** → **UI** → **Text - TextMeshPro**
2. Rename it to **"ScoreText"**
3. In Inspector, set **Rect Transform**:
   - **Anchor**: Top Right
   - **Position X**: -50
   - **Position Y**: -30
   - **Width**: 200
   - **Height**: 50
4. Set **TextMeshPro - Text (UI)** properties:
   - **Text**: "Score: 0"
   - **Font Size**: 36
   - **Alignment**: Right
   - **Color**: White (or your preferred color)

### Step 4: Assign Text References to Scripts

#### For PlayerHealth Script:
1. Select the **Player** GameObject in Hierarchy
2. In Inspector, find **PlayerHealth** component
3. Drag **HealthText** from Hierarchy into the **Health Text** field

#### For ScoreManager Script:
1. Find the GameObject with **ScoreManager** script (might be "GameManager" or similar)
2. If ScoreManager doesn't exist on any GameObject:
   - Create empty GameObject: Right-click Hierarchy → **Create Empty**
   - Rename it to **"GameManager"**
   - Add Component → **ScoreManager** script
3. Select the GameObject with **ScoreManager**
4. In Inspector, drag **ScoreText** from Hierarchy into the **Score Text** field

### Step 5: Verify Setup
1. Press **Play**
2. Check that:
   - "Health: 100" appears in top-left corner
   - "Score: 0" appears in top-right corner
   - Both update correctly when you collect items or take damage

## Alternative: Using Anchors for Responsive Design

For better screen adaptation, you can use anchors:

### Health Text (Top Left):
- **Anchor Presets**: Hold **Alt + Shift** and click **Top-Left** preset
- **Pos X**: 20
- **Pos Y**: -20

### Score Text (Top Right):
- **Anchor Presets**: Hold **Alt + Shift** and click **Top-Right** preset
- **Pos X**: -20
- **Pos Y**: -20

