﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using thelab.mvc;

public class HexModel : Model<HexApp> {

    // Searches the Hierarchy for Models
    public TileModel hex { get { return m_hex = Assert<TileModel>(m_hex); } }
    private TileModel m_hex;

    public HexMapModel hexMap { get { return m_hexMap = Assert<HexMapModel>(m_hexMap); } }
    private HexMapModel m_hexMap;

    // Do we need a Game Board model?
    public GameBoardModel gameBoard { get { return m_gameBoard = Assert<GameBoardModel>(m_gameBoard); } }
    private GameBoardModel m_gameBoard;

}
