﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenTK;





namespace KailashEngine.World.Model
{
    class Mesh
    {

        [StructLayout(LayoutKind.Sequential)]
        public struct Vertex
        {
            public Vector3 position;
            public Vector2 uv;
            public Vector3 normal;
            public Vector3 tangent;
        }


        protected string _id;
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }

        // Mesh can contain partial meshes with their own materials
        protected List<Mesh> _partials;
        public List<Mesh> partials
        {
            get { return _partials; }
            set { _partials = value; }
        }

        // Material
        private Material _material;
        public Material material
        {
            get { return _material; }
            set { _material = value; }
        }



        // Vertex Buffer Object
        protected int _vbo;
        public int vbo
        {
            get { return _vbo; }
            set { _vbo = value; }
        }
        // Index Buffer Object
        protected int _ibo;
        public int ibo
        {
            get { return _ibo; }
            set { _ibo = value; }
        }
        // Vertex Array Object
        protected int _vao;
        public int vao
        {
            get { return _vao; }
            set { _vao = value; }
        }

        // Mesh Vertices
        private List<Vertex> _vertices;
        public List<Vertex> vertices
        {
            get { return _vertices; }
            set { _vertices = value; }
        }
        // Mesh Indices
        private List<uint> _indices;
        public List<uint> indices
        {
            get { return _indices; }
            set { _indices = value; }
        }
        // Vertex to Index Mapper Dictionary
        private Dictionary<Vertex, uint> _vtoi;

        // VAO Helpers
        private Vertex[] _vertex_data;
        public Vertex[] vertex_data
        {
            get { return _vertex_data; }
            set { _vertex_data = value; }
        }
        private int _vertex_data_size;
        public int vertex_data_size
        {
            get { return _vertex_data_size; }
            set { _vertex_data_size = value; }
        }
        private uint[] _index_data;
        public uint[] index_data
        {
            get { return _index_data; }
            set { _index_data = value; }
        }
        private int _index_data_size;
        public int index_data_size
        {
            get { return _index_data_size; }
            set { _index_data_size = value; }
        }




    }
}